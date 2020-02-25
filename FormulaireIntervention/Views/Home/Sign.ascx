﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Sign.ascx.cs" Inherits="FormulaireIntervention.Views.Home.Sign" %>

    <script src="~/Scripts/signature_pad.umd.js"></script>
    <script>
        $(function () {

            var canvas = document.querySelector('#signature');
            var pad = new SignaturePad(canvas);

            $('#accept').click(function () {

                var data = pad.toDataURL();

                $('#savetarget').attr('src', data);
                $('#SignatureDataUrl').val(data);
                $('#data2').val(data);

                pad.off();

            });

        });
    </script>


<h2>Client Sign</h2>


<form id="formsign" action="" method="POST" runat="server">
    <p>
        <asp:HiddenField ID="data" runat="server" />
        <canvas width="500" height="400" id="signature"
                style="border:1px solid black"></canvas><br>
        <button type="button" id="accept"
                class="btn btn-primary">
            Accept signature
        </button>
        <button type="submit" id="save"
                class="btn btn-primary">
            Save
        </button><br>
        <img width="500" height="400" id="savetarget"
             style="border:1px solid black"><br>
        <input type="text" id="data2" hidden>
        <asp:TextBox ID="data2" runat="server" hidden />

    </p>
</form>