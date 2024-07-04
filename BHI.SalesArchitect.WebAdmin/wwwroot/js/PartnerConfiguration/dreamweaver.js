"use strict";
const DREAMWEAVER_GRID = `#Dreamweaver_Grid`;
const UPDATE_DREAMWEAVER_CONFIGURATION = "partnerconfiguration/savedreamweaverconfiguration";

$(function () {
    $('input[name="isDreamweaver"]').on('change', toggleGridVisibility);

    $(DREAMWEAVER_GRID).jqGrid({
        width: null,
        datatype: 'json',
        height: '270px',
        pager: '#pager',
        mtype: 'Get',
        rowList: [20, 30, 40, 50],
        rowNum: 20,
        url: '/PartnerConfiguration/GetCommunitiesGrid',
        viewrecords: true,
        emptyrecords: 'No Communities Found',
        colModel: [
            {
                name: 'ID',
                hidden: true,
                index: 'ID'
            }, {
                align: 'center',
                name: 'cell.DWStatus',
                label: 'DW Status',
                sortable: true,
                formatter: formatStatus
            }
            , {
                align: 'center',
                name: 'cell.Name',
                label: 'Community',
                sortable: true,
                index: 'cell.Name'
            }, {
                align: 'center',
                name: 'cell.Brand',
                label: 'Brands',
                sortable: true,
                index: 'cell.Brand'
            }, {
                align: 'center',
                name: 'cell.Market',
                label: 'Market',
                sortable: true,
                index: 'cell.Market'
            }
        ],
        loadComplete: function () {
            $(DREAMWEAVER_GRID).jqGrid('setGridWidth', $('.tab-content').width(), true);
        }
    });
    /* $('.dwRadio').on('click', function (a) {
         var commId = $(this).data('commid');
         var val = $(this).val();
         commArray = commArray.filter(function (e) {
             if (commId !== e.commId) {
                 return e;
             }
         });
         commArray.push({ commId: commId, val: val });
     });*/

    /*$(document).on('keyup', '#searchBox', function (e) {
        if (e.keyCode === 13) {
            e.preventDefault();
            $("#searchButton").click();
        }
    });*/
});

function toggleGridVisibility() {
    var isChecked = $('input[name="isDreamweaver"]:checked').val();
    if (isChecked === 'true') {
        $('#dreamweaver_grid').css('display', 'block');
    } else {
        $('#dreamweaver_grid').css('display', 'none');
    }
}


function formatStatus(a, b, c) {
    const statusOptions = [
        { value: '1', label: 'Active' },
        { value: '2', label: 'Inactive' },
        { value: '3', label: 'Pending' }
    ];

    const statusInputs = statusOptions.map(option => {
        const checked = a === option.value ? 'checked' : '';
        return `<input class='m-1' type='radio' ${checked} data-commId='${c[0]}' name='dwStatus_${c[0]}' value='${option.value}' /><label>${option.label}  </label>`;
    });

    return statusInputs.join('');
}

function clearSearch() {
    if (!$('#clear-search').hasClass('disable')) {
        $('#searchBox').val("");
        jQuery(DREAMWEAVER_GRID).jqGrid().setGridParam({ postData: { searchTerm: null }, page: 1 }).trigger('reloadGrid');
        $('#clear-search').addClass('disable');
    }
}

function searchCommunityGrid() {
    var searchTerm = $('#searchBox').val().trim();
    if (searchTerm != null && searchTerm != "") {
        jQuery(DREAMWEAVER_GRID).jqGrid().setGridParam({ postData: { searchTerm: searchTerm }, page: 1 }).trigger('reloadGrid');
        $('#clear-search').removeClass('disable');
    }
}

async function updateDreamweaverConfiguration() {
    let data = getFormObj("dreamweaverConfigurationForm");
    let dreamweaverObj = {
        IsDreamweaver: data.isDreamweaver == 'true' ? true : false
    }
    let result = await executeHttpRequest(UPDATE_DREAMWEAVER_CONFIGURATION, METHOD_POST, dreamweaverObj);
    if (result.success == true)
        showToast("Configuration Updated Successfully");
    else
        showToast("Unsuccessful", false);
    console.log(data);
}