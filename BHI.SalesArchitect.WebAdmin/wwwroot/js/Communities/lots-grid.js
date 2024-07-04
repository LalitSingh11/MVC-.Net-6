"use strict";
const GRID_LOTS = "#GridLots";
var currentLotRowId = -1;
var ckEditorInstance;

$(function () {
    ClassicEditor
        .create(document.querySelector('#descriptionEditor'), {
            removePlugins: ['MediaEmbed'],
        })
        .then(editor => {
            ckEditorInstance = editor;
        })
        .catch(error => {
            console.error(error);
        });
})

function fetchLots(commId) {
    $(GRID_LOTS).jqGrid().setGridParam({ postData: { commId: commId } }).trigger('reloadGrid');
}

function onLotsGridComplete(data) {
    $(`#lot-count`).text(`Lots(${data?.total ?? 0})`);
    if (data?.total > 0) {
        let firstId = $(`${GRID_LOTS} tr`).eq(1).attr("id");
        $(GRID_LOTS).jqGrid('setSelection', firstId);
        currentLotRowId = firstId;
    }
    else {
        emptyLotInfoForm();
    }
}

function onLotSelectRow(rowId, status) {
    if (status) {
        currentLotRowId = rowId;
        populateLotInfoForm();
    }
}


