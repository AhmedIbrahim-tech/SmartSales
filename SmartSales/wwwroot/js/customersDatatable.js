$(document).ready(function () {
    $('#Categories').dataTable({
        "processing": true,
        "serverSide": true,
        "filter": true,
        "ajax": {
            "url": "/Categories/Index",
            "type": "POST",
            "datatype": "json"
        },
        "columnDefs": [{
            "targets": [0],
            "visible": false,
            "searchable": false
        }],
        "columns": [
            { "data": "Category_Id", "name": "Category_Id", "autowidth": true },
            { "data": "Category_Name", "name": "Category_Name", "autowidth": true },
            {
                "render": function (data, type, full, meta) { return '<a class="btn btn-info" href="/Categories/Edit/' + full.Category_Id + '">Edit</a>'; }
            },
            {
                data: null,
                render: function (data, type, row) {
                    return "<a href='#' class='btn btn-danger' onclick=DeleteData('" + row.Category_Id + "'); >Delete</a>";
                }
            },
            
        ]
    });
});


function DeleteData(Category_Id) {
    if (confirm("Are you sure you want to delete ...?")) {
        Delete(Category_Id);
    } else {
        return false;
    }
}


function Delete(CustomerID) {
    var url = '@Url.Content("~/")' + "Categories/Delete";

    $.post(url, { ID: CustomerID }, function (data) {
        if (data) {
            oTable = $('#example').DataTable();
            oTable.draw();
        } else {
            alert("Something Went Wrong!");
        }
    });
}