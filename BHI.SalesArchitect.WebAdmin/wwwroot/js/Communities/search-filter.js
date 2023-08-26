"use strict";
const COMMUNITIES_GRID = "#Communities";

function onCommunityTypeChange(selectedValue) {
    let searchTerm = $('#searchBox').val()?.trim();
    let commStatusFilterValue = $('#commStatusFilter').val();
    $(COMMUNITIES_GRID).jqGrid().setGridParam({ postData: { searchTerm: searchTerm, commStatusType: commStatusFilterValue, commType: selectedValue }, page: 1 }).trigger('reloadGrid');
}

function onCommunityStatusChange(selectedValue) {
    let searchTerm = $('#searchBox').val()?.trim();
    let commTypeFilterValue = $('#commTypeFilter').val();
    $(COMMUNITIES_GRID).jqGrid().setGridParam({ postData: { searchTerm: searchTerm, commStatusType: selectedValue, commType: commTypeFilterValue }, page: 1 }).trigger('reloadGrid');
}

function clearSearch() {
    $("#Communities").jqGrid().trigger('reloadGrid');
    if (!$('#clear-search').hasClass('disable')) {
        $('#searchBox').val("");
        $(COMMUNITIES_GRID).jqGrid().setGridParam({ postData: { searchTerm: null }, page: 1 }).trigger('reloadGrid');
        $('#clear-search').addClass('disable');
    }
}

function searchCommunityGrid() {
    let searchTerm = $('#searchBox').val()?.trim();
    if (searchTerm) {
        $(COMMUNITIES_GRID).jqGrid().setGridParam({ postData: { searchTerm: searchTerm }, page: 1 }).trigger('reloadGrid');
        $('#clear-search').removeClass('disable');
    }
}