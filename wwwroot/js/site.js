// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function realizaPostFornecedor()
{
    var parametros =
    {
        nome_fornecedor: $("#txtNome").val(),
        telefone_fornecedor: $("#txtFone").val(),
        email_fornecedor: $("#txtEmail").val(),
        site_fornecedor: $("#txtSite").val()
    };

    $("#modalLoading").modal("show");
    $.post("/Cadastro/CadastroFornecedor", parametros)
        .done(function(data)
        {
            if(data.status == "OK")
            {
                $("#modalLoading").modal('hide');
                $("#divFormularioFornecedor").hide();
                $("#divCadastrado").fadeIn();
            }
            else
            {
                $("#modalLoading").modal('hide');
                alert(data.mensagem);
            }
        });
}

function realizaPostCamiseta()
{
    var parametros =
    {
        nome_camiseta: $("#txtNome").val(),
        tamanho_camiseta: $("#inlineRadioOptions").val(),
        cor_camiseta: $("#txtColor").val(),
        estampa_camiseta: $("#txtEstampa").val(),
        quantidade_camiseta: $("#intQuantidade").val(),
        FornecedorId: $("#selFornecedor").val()
    };

    $("#modalLoading").modal("show");
    $.post("/Cadastro/CadastroCamiseta", parametros)
        .done(function(data)
        {
            if(data.status == "OK")
            {
                $("#modalLoading").modal('hide');
                $("#divFormularioCamiseta").hide();
                $("#divCadastrado").fadeIn();
            }
            else
            {
                $("#modalLoading").modal('hide');
                alert(data.mensagem);
            }
        });
}

function realizaPostColaborador()
{
    var parametros =
    {
        nome_colaborador: $("#txtNome").val(),
        login_colaborador: $("#txtLogin").val(),
        senha_colaborador: $("#txtSenha").val(),
        nascimento_colaborador: $("#dateNasc").val()
    };

    $("#modalLoading").modal("show");
    $.post("/Cadastro/CadastroColaborador", parametros)
        .done(function(data)
        {
            if(data.status == "OK")
            {
                $("#modalLoading").modal('hide');
                $("#divFormularioColaborador").hide();
                $("#divCadastrado").fadeIn();
            }
            else
            {
                $("#modalLoading").modal('hide');
                alert(data.mensagem);
            }
        });
}

function realizaPostCliente()
{
    var parametros =
    {
        nome_cliente: $("#txtNome").val(),
        telefone_cliente: $("#txtFone").val(),
        email_cliente: $("#txtEmail").val(),
        tamanho_cliente: $("input[name=inlineRadioOptions]:checked", '#formCadastroCliente').val()
    };

    $("#modalLoading").modal("show");
    $.post("/Cadastro/CadastroCliente", parametros)
        .done(function(data)
        {
            if(data.status == "OK")
            {
                $("#modalLoading").modal('hide');
                $("#divFormularioCamiseta").hide();
                $("#divCadastrado").fadeIn();
            }
            else
            {
                $("#modalLoading").modal('hide');
                alert(data.mensagem);
            }
        });
}

function alternaFuncao()
{
    $("#lista").hide();
    $("#cadastro").show();
}

$(document).ready(
    function(){

        $("#formCadastroFornecedor").submit(function(e){
            e.preventDefault();
            realizaPostFornecedor();
        })
        $("#formCadastroCamiseta").submit(function(e){
            e.preventDefault();
            realizaPostCamiseta();
        })
        $("#formCadastroColaborador").submit(function(e){
            e.preventDefault();
            realizaPostColaborador();
        })
        $("#formCadastroCliente").submit(function(e){
            e.preventDefault();
            realizaPostCliente();
        })
    });
