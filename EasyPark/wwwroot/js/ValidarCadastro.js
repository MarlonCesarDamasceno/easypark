var formulario = document.getElementById("formulario-usuario");
    formulario.onsubmit = validarDados;
    function validarDados() {
        var campos = formulario.querySelectorAll("input, textarea");
    var areaDeMensagens = document.getElementById("area-de-mensagens");
    var camposComErro = [];
    var contadorErros = 0;
    for (var contador = 0; contador < campos.length; contador++) {
            if (campos[contador].value == "") {
        camposComErro[contadorErros] = campos[contador];
    contadorErros++;
            }
        }
        if (camposComErro.length > 0) {
            var erros = "<h2 tabindex='-1' id='titulo-area-de-mensagens'>Existem " + camposComErro.length + " erros no formulário</h2>";
    erros += "<p id='texto-area-de-mensagens'>Corrija os campos a seguir:</p>";
    erros += "<ul>";
        for (contadorErros = 0; contadorErros < camposComErro.length; contadorErros++) {
            erros += "<li><a href='#" + camposComErro[contadorErros].id + "'>O campo " + camposComErro[contadorErros].id + " não pode ficar vazio</a></li>";
            }
        erros += "</ul>";
    areaDeMensagens.innerHTML = erros;
        } else {
            var confirmacao = "<h2 tabindex='-1' id='titulo-area-de-mensagens'> Confirmação de envio</h2>";
    confirmacao += "<p id='texto-area-de-mensagens'>verifique se seus dados a seguir foram preenchidos corretamente</p>";
    confirmacao += "<ul>";
        for (var contador = 0; contador < campos.length - 1; contador++) {
            confirmacao += "<li><a href='#" + campos[contador].id + "'>" + campos[contador].id + ": " + campos[contador].value + " </a> </li>";
            }
        confirmacao += "</ul>";
    confirmacao += "<button onclick='enviarFormulario();'>Enviar dados Preenchidos</button>";
    areaDeMensagens.innerHTML = confirmacao;
        }

    areaDeMensagens.setAttribute("aria-labelledby", "titulo-area-de-mensagens");
    areaDeMensagens.setAttribute("aria-describedby", "texto-area-de-mensagens");

    areaDeMensagens.querySelector("h2").focus();

    return false;
    }

    function enviarFormulario() {
        alert("Parabéns! Cadastro efetuado com sucesso.");
    formulario.submit();
    }

alert("peido");