<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro_Pessoa.aspx.cs" Inherits="WebApplication3.Cadastro_Pessoa" %>

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
                <h2>Cadastro de Pessoa</h2>
                <div class="panel panel-default">
                    <div class="panel-heading"></div>
                    <div class="panel-body">
                        <div>
                            <div class="form-group col-sm-3">
                                <label for="txtNameCadastro">Nome</label>
                                <input type="text" value="" id="txtNameCadastro" placeholder="Nome" runat="server" class="form-control">
                                <label for="txtNameCadastro">Cpf</label>
                                <input type="text" value="" id="txtCpfCadastro" placeholder="Cpdf" runat="server" class="form-control">
                            </div>
                            <div class="form-group col-sm-3">
                                <label for="txtEmailCadastro">E-mail</label>
                                <input type="email" class="form-control" id="txtEmailCadastro" runat="server" placeholder="Teste@teste.com">
                                <label for="txtEmailCadastro">Data de Nascimento</label>
                                <input type="date" class="form-control" id="txtDtNascimentoCadastro" runat="server" placeholder="Data_Nascimento">
                            </div>
                        </div>
                        <hr></hr>
                        <br />
                        <div>
                            <label for="txtDDDCadastro">DDD:</label>
                            <input type="text" class="form-control" id="txtDDDCadastro" runat="server" placeholder="DDD">

                            <label for="txtTelefoneCadastro">Telefone:</label>
                            <input type="tel" class="form-control" id="txtTelefoneCadastro" runat="server" placeholder="Telefone">
                            </br>
                            <button type="button" class="btn btn-success" id="btnAddCadastro" runat="server" onserverclick="btnAddCadastro_ServerClick">
                                <span class="glyphicon glyphicon-saved "></span>Adicionar
                            </button>
                            <hr></hr>
                            </br>
                            <div id="Listtelefone">
                                <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover table-striped" GridLines="None">
                                    <Columns>
                                        <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Ações" ShowHeader="True" Text="Deletar" />
                                    </Columns>


                                </asp:GridView>
                            
                              <button type="button" class="btn btn-success" id="btnSalvar" runat="server" onserverclick="btnSalvar_ServerClick">
                                <span class="glyphicon glyphicon-apple"></span>Cadastrar
                            </button>
                            
                            
                            </div>

                        </div>
                    </div>
            </div>
        </div>
        </div>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Pessoa]"></asp:SqlDataSource>
    </form>
</body>
</html>
