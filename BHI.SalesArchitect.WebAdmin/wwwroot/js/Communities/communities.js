"use strict";
var currentCommRowId = -1;

function onCommunitiesLoadComplete(xhr) {
    console.log(xhr);
    if (xhr.records > 0) {
        showCommunityRelatedViews();
        var firstId = $(`${COMMUNITIES_GRID} tr`).eq(1).attr("id");
        if (firstId != undefined) {
            $(COMMUNITIES_GRID).jqGrid('setSelection', firstId);
            currentCommRowId = firstId;
        }
    }
    else {
        hideCommunityRelatedViews();
    }
}

function onCommunitiesRowSelected(rowid) {
    currentCommRowId = rowid;
    fetchLots(rowid);
    setCommunityTitles(rowid);
    setCommunityCustomizableContent(rowid);
    setLotStatusTable(rowid);
    setISPConfiguration(rowid);
}

function hideCommunityRelatedViews() {
    $('#manageLotsTab').hide();
    $('#manageLotsTabContent').hide();
}

function showCommunityRelatedViews() {
    $('#manageLotsTab').show();
    $('#manageLotsTabContent').show();
}