<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="SimpleCalculator.Calculator" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Calculator</title>
    <style>
        .container {
            text-align: center;
            margin-top: 50px;
        }
        .buttons {
            display: flex;
            justify-content: center;
            margin-top: 20px;
        }
        .buttons button {
            width: 50px;
            height: 50px;
            font-size: 20px;
            margin: 5px;
        }
        .result {
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Simple Calculator</h2>
            <div>
                <label for="number1">Number 1: </label>
                <asp:TextBox ID="number1TextBox" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="number2">Number 2: </label>
                <asp:TextBox ID="number2TextBox" runat="server"></asp:TextBox>
            </div>
            <div class="buttons">
                <asp:Button ID="addButton" runat="server" Text="+" OnClick="AddButton_Click" />
                <asp:Button ID="subtractButton" runat="server" Text="-" OnClick="SubtractButton_Click" />
                <asp:Button ID="multiplyButton" runat="server" Text="*" OnClick="MultiplyButton_Click" />
            </div>
            <div class="result">
                <asp:Label ID="resultLabel" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
