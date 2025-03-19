$(document).ready(function () {
    $("#categoria").change(function () {
        var categoriaId = $(this).val();
        $.get("/Productos/Index?categoriaId=" + categoriaId, function (data) {
            var rows = $(data).find("#productos-table").html();
            $("#productos-table").html(rows);
        });
    });
});
