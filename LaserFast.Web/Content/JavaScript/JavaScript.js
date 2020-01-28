<script type="text/javascript" src="https://ajax.cdnjs.com/ajax/libs/json2/20110223/json2.js"></script>



    <script>
        document.getElementById('<%=GridView1.Rows[1].Cells[1].FindControl("txtPrincipalAmount").ClientID %>').value = 1000;
      </script>





    <script type="text/javascript">
        function GetTableValues() {
        //Create an Array to hold the Table values.
        var clientes = new Array();

        //Reference the Table.
        var table = document.getElementById("grdClientes");

        //Loop through Table Rows.
        for (var i = 1; i < table.rows.length; i++) {
            //Reference the Table Row.
            var row = table.rows[i];

        //Copy values from Table Cell to JSON object.
            var customer = {};
        Id = row.cells[0].innerHTML;
        Pessoa.Nome = row.cells[1].innerHTML;
        Pessoa.Email = row.cells[2].innerHTML;
        customers.push(customer);
    }

    //Convert the JSON object to string and assign to Hidden Field.
    document.getElementsByName("CustomerJSON")[0].value = JSON.stringify(customers);
}

</script>