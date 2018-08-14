<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="WebApplication3.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div id="Principal">
            <div class="container">
                <h2>Listagem de Pessoas</h2>
                <div class="panel panel-default">
                    <div class="panel-heading"></div>
                    <div class="panel-body">
                        <label>Nome:</label>
                        <input type="text" value="" id="txtName" placeholder="Nome" runat="server">
                        <label>Cpf:</label>
                        <input type="text" value="" id="txtCpf" placeholder="Cpf" runat="server">


                        <button type="button" class="btn btn-info" id="btnPesquisar" runat="server" onserverclick="btnPesquisar_ServerClick">
                            <span class="glyphicon glyphicon-search"></span>Pesquisar
                        </button>

                        <button type="button" class="btn btn-success" id="btnCadastrar" runat="server" onserverclick="btnCadastrar_ServerClick">
                            <span class="glyphicon glyphicon-save  "></span>Cadastrar
                        </button>
                        <hr></hr>
                        <div id="listPessoas">
                        
                            <asp:GridView ID="GridPessoas" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" CssClass="table table-hover table-striped" GridLines="None" OnRowDeleting="GridPessoas_RowDeleting" OnRowUpdating="GridPessoas_RowUpdating">
                                <Columns>
                                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                                    <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                                    <asp:BoundField DataField="Cpf" HeaderText="Cpf" SortExpression="Cpf" />
                                    <asp:BoundField DataField="DataNascimento" HeaderText="Idade" SortExpression="DataNascimento" ReadOnly="True" />
                                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                                    <asp:CommandField ButtonType="Button" HeaderText="Ações" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
                                </Columns>
                            </asp:GridView>




                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="
SELECT id, Nome,Email, Cpf, FLOOR(DATEDIFF(DAY, DataNascimento, GETDATE()) / 365.25)  as DataNascimento FROM [Pessoa]"></asp:SqlDataSource>




                        </div>



                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
