const DREAMWEAVER_GRID = `#Dreamweaver_Grid`;

$(function () {    
    $('input[name="isDreamweaver"]').on('change', toggleGridVisibility);

    $(DREAMWEAVER_GRID).jqGrid({
        width: null,
        datatype: 'json',
        height: '260px',
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
            $(DREAMWEAVER_GRID).jqGrid('setGridWidth', $('.tab-content').width() - 2, true);
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
    var active = a === 'Active' ? true : false;
    var inactive = a === 'Inactive' ? true : false;
    var pending = a === 'Pending' ? true : false;
    var activateRadioButton = active ? "<input class='dwRadio' type='radio' checked data-commId='" + c[0] + "' name='dwStatus_" + c[0] + "' value='1' /><label>Active</label>" : "<input class='dwRadio' type='radio' data-commId='" + c[0] + "' name='dwStatus_" + c[0] + "' value='1' /><label>Active</label>";
    var inactivateRadioButton = inactive ? "<input class='dwRadio' type = 'radio' checked data-commId='" + c[0] + "' name = 'dwStatus_" + c[0] + "' value = '2' /> <label>Inactive</label>" : "<input class='dwRadio' type = 'radio' data-commId='" + c[0] + "' name = 'dwStatus_" + c[0] + "' value = '2' /> <label>Inactive</label>";
    var pendingButton = pending ? "<input class='dwRadio' type='radio' checked name='dwStatus_" + c[0] + "' data-commId='" + c[0] + "' value='3' /><label>Pending</label>" : "<input class='dwRadio' type='radio' name='dwStatus_" + c[0] + "' data-commId='" + c[0] + "' value='3' /><label>Pending</label>";
    return activateRadioButton + inactivateRadioButton + pendingButton;
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