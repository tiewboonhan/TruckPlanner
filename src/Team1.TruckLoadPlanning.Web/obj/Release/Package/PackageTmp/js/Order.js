function PopulateRecord() {
    $.ajax({
        type: "POST",
        url: window.makeUrl("/Order/CollectResult"),
        dataType: 'json',
        async: true,
        cache: false,
        success: function (repsonse) {
            alert(response)
            //for (var i = 0; i < repsonse.length; i++) {
            //    var jobElement = repsonse[i];
            //    $("#txtTruck_" + jobElement.ItemId).empty();
            //}

        }
    });

}