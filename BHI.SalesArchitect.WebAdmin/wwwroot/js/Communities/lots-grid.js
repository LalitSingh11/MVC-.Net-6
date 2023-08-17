"use strict";
var Grid_Lots = "#GridLots";
function fetchLots(commId) {
    $(Grid_Lots).jqGrid().setGridParam({ postData: { commId: commId } }).trigger('reloadGrid');
}

function onLotsGridComplete(data) {
    $(`#lot-count`).text(`Lots(${data?.total ?? 0})`);
    console.log(data?.total);
}