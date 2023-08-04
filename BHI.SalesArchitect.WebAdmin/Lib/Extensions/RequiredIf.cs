using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

public class RequiredIfAttribute : ValidationAttribute
{
    private readonly RequiredAttribute _innerAttribute = new RequiredAttribute();

    public string DependentProperty { get; set; }
    public object TargetValue { get; set; }

    public RequiredIfAttribute(string dependentProperty, object targetValue)
    {
        this.DependentProperty = dependentProperty;
        this.TargetValue = targetValue;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        // get a reference to the property this validation depends upon
        var containerType = validationContext.ObjectInstance.GetType();
        var field = containerType.GetProperty(this.DependentProperty);

        if (field != null)
        {
            // get the value of the dependent property
            var dependentValue = field.GetValue(validationContext.ObjectInstance);

            // compare the value against the target value
            if ((dependentValue == null && string.IsNullOrEmpty(value as string)) ||
                ((dependentValue is bool dependentBoolValue) && dependentBoolValue == false && string.IsNullOrEmpty(value as string)))
            {
                // match => means we should try validating this field
                return new ValidationResult(this.ErrorMessage, new[] { validationContext.MemberName });
            }
        }

        return ValidationResult.Success;
    }

    /*public void AddValidation(ClientModelValidationContext context)
    {
        var rule = new ModelClientValidationRule
        {
            ErrorMessage = FormatErrorMessage(context.ModelMetadata.GetDisplayName()),
            ValidationType = "requiredif"
        };

        string depProp = BuildDependentPropertyId(context.ModelMetadata, context.ViewContext);

        // find the value on the control we depend on;
        // if it's a bool, format it javascript style 
        // (the default is True or False!)
        string targetValue = (this.TargetValue ?? "").ToString();
        if (this.TargetValue.GetType() == typeof(bool))
            targetValue = targetValue.ToLower();

        rule.ValidationParameters.Add("dependentproperty", depProp);
        rule.ValidationParameters.Add("targetvalue", targetValue);

        context.Attributes.Add("data-val-requiredif", FormatErrorMessage(context.ModelMetadata.GetDisplayName()));
        context.Attributes.Add("data-val-requiredif-dependentproperty", depProp);
        context.Attributes.Add("data-val-requiredif-targetvalue", targetValue);

        context.ValidationMetadata.ValidatorMetadata.Add(this);
    }

    private string BuildDependentPropertyId(ModelMetadata metadata, ViewContext viewContext)
    {
        // build the ID of the property
        string depProp = viewContext.ViewData.TemplateInfo.GetFullHtmlFieldId(this.DependentProperty);
        // unfortunately this will have the name of the current field appended to the beginning,
        // because the TemplateInfo's context has had this fieldname appended to it. Instead, we
        // want to get the context as though it was one level higher (i.e. outside the current property,
        // which is the containing object (our Person), and hence the same level as the dependent property.
        var thisField = metadata.PropertyName + "_";
        if (depProp.StartsWith(thisField))
            // strip it off again
            depProp = depProp.Substring(thisField.Length);
        return depProp;
    }*/
}
