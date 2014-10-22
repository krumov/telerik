function generateData(rows) {
    var data = {
        rows: []
    };

    for (var i = 0; i < rows; i++) {
        data.rows.push({
            number: i,
            title: 'Random title ' + i,
            date1: "Wed 18:00, 28-May-2014",
            date2: "Thu 14:00, 29-May-2014"
        });
    }
    return data;
}