﻿$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    let table = $('#myTable').DataTable({
        "ajax": {
            "url": '/admin/Company/Getall', // Corrected the syntax
            "type": "GET" // You can specify the request type, default is GET
        },
        "columns": [
            { data: 'name', "width": "15%" },
            { data: 'address', "width": "15%" },
            { data: 'city', "width": "15%" },
            { data: 'state', "width": "15%" },
            { data: 'postalCode', "width": "15%" },
            { data: 'phoneNumber', "width": "15%" },
            {
                data: 'id',
                "width": "15%",
                "render": function (data) {
                    return `
                        <div class="btn-group d-flex justify-content-end">
                            <a href="/Admin/Company/Edit?id=${data}" class="btn btn-primary shadow-sm">
                                <i class="bi bi-pencil-square"></i> Edit
                            </a>
                            <a onClick="Delete('/Admin/Company/Delete/${data}')" class="btn btn-danger shadow-sm">
                                <i class="bi bi-trash-fill"></i> Delete
                            </a>
                        </div>
                    `;
                }
            },
        ]
    }).ajax.reload(null, false);;
}

function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: "DELETE", // Correctly specify the method as a string
                success: function (data) {
                    toastr.success(data.message);
                    $('#myTable').DataTable().ajax.reload(); // Reload the DataTable
                },
                error: function (xhr, status, error) {
                    toastr.error("Error deleting the product: " + xhr.responseJSON.message); // Handle errors
                }
            });
        }
    });
}
