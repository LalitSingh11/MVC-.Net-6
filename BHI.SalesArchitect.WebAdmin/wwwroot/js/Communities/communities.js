"use strict";
var currentCommRowId = -1
$().ready(function () {
    ClassicEditor
        .create(document.querySelector('#descriptionEditor'), {
            removePlugins: ['MediaEmbed'],
        })
        .catch( error => {
            console.error( error );
        } );
})


function onCommunitiesLoadComplete() {
    var firstId = $(`${COMMUNITIES_GRID} tr`).eq(1).attr("id");
    if (firstId != undefined) {
            $(COMMUNITIES_GRID).jqGrid('setSelection', firstId);
        currentCommRowId = firstId;
        fetchLots(firstId);
    }
}

function onCommunitiesRowSelected(rowid) {
    currentCommRowId = rowid;
    fetchLots(rowid);
}

