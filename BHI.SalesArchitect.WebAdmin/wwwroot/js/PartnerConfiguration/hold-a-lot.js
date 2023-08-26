const GET_CUSTOMIZABLE_CONTENT_URL = "partnerconfiguration/getcustomizedcontent"

$(function () {
    setCustomizableContent();
});

async function setCustomizableContent() {
    var contentList = await executeHttpRequest(GET_CUSTOMIZABLE_CONTENT_URL, METHOD_GET);
    console.log(contentList);

    const tableBody = $("#customizableContentTable tbody");

    contentList.forEach(content => {
        const row = $("<tr>");
        row.append($("<td>").text(content.locationDescription));
        row.append($("<td>").text(content.contentType));
        row.append($("<td>").text(content.value));

        const actionCell = $("<td>").html(`<button id=${content.id} data-bs-toggle="modal" data-bs-target="#customizedContentModal" class="btn-primary">Edit</button>`);
        row.append(actionCell);
        tableBody.append(row);
    });
}