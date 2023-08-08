"use strict";
const COMMUNITIES_GRID = "Communities";

function onCommunityTypeChange(selectedValue) {
    var searchTerm = $('#searchBox').val().trim();
    var commStatusFilterValue = $('#commStatusFilter').val();
    jQuery(`#${COMMUNITIES_GRID}`).jqGrid().setGridParam({ postData: { searchTerm: searchTerm, commStatusType: commStatusFilterValue, commType: selectedValue }, page: 1 }).trigger('reloadGrid');
}

function onCommunityStatusChange(selectedValue) {
    var searchTerm = $('#searchBox').val().trim();
    var commTypeFilterValue = $('#commTypeFilter').val();
    jQuery(`#${COMMUNITIES_GRID}`).jqGrid().setGridParam({ postData: { searchTerm: searchTerm, commStatusType: selectedValue, commType: commTypeFilterValue }, page: 1 }).trigger('reloadGrid');
}

function clearSearch() {
    jQuery("#Communities").jqGrid().trigger('reloadGrid');
    if (!$('#clear-search').hasClass('disable')) {
        $('#searchBox').val("");
        jQuery(`#${COMMUNITIES_GRID}`).jqGrid().setGridParam({ postData: { searchTerm: null }, page: 1 }).trigger('reloadGrid');
        $('#clear-search').addClass('disable');
    }
}

function searchCommunityGrid() {
    var searchTerm = $('#searchBox').val().trim();
    if (searchTerm != null && searchTerm != "") {
        jQuery(`#${COMMUNITIES_GRID}`).jqGrid().setGridParam({ postData: { searchTerm: searchTerm }, page: 1 }).trigger('reloadGrid');
        $('#clear-search').removeClass('disable');
    }
}