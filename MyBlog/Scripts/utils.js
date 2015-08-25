$(document).ready(function () {
    $('.posted-date').each(function () {
        try {
                var text = $(this).html();
                var serverDate = moment.utc(text).local().format('LL');

                $(this).html(serverDate);
        }
        catch (ex) {
            console.warn("Error converting date time", ex);
        }
    });
});