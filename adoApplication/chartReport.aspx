<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chartReport.aspx.cs" Inherits="adoApplication.chartReport" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Chart ID="Chart1" runat="server" Width="1200px">
            <Series> 
                <asp:Series Name="Series2" LegendText="Monthly Sale" ChartType="Bubble" BorderWidth="5"></asp:Series>
                <asp:Series Name="Series1" LegendText="Monthly Purchase" ChartType="Bubble"  BorderWidth="5"></asp:Series>
                <asp:Series Name="Series3" LegendText="Monthly Profit & Loss" ChartType="Bubble"  BorderWidth="5" IsValueShownAsLabel="true"></asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisX Interval="1"></AxisX>
                    <AxisY></AxisY>
                </asp:ChartArea>
            </ChartAreas>
            <Legends>
                <asp:Legend Name="Legend1" Title="Chart Detail"></asp:Legend>
            </Legends>
        </asp:Chart>
    </form>
</body>
</html>
