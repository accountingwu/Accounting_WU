$('#myTable').on('click', '.clickable-row', function (event) {
    $(this).addClass('bg-info').siblings().removeClass('bg-info');
});