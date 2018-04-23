<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
	<style type="text/css">
		html, body, form
		{
			margin: 0;
			padding: 0;
		}
	</style>
        <script src="DXTREME/js/jquery-1.9.1.min.js" type="text/javascript"></script>
        <script src="DXTREME/js/globalize.js" type="text/javascript"></script>
        <script src="DXTREME/js/knockout-2.2.1.js" type="text/javascript"></script>
        <script src="DXTREME/js/dx.chartjs.js" type="text/javascript"></script>
	<script type="text/javascript">
		$(function () {
			$("#chartContainer").dxChart({
				dataSource: chartData,
				commonSeriesSettings: {
					argumentField: 'PlatformName',
					type: 'bar'
				},
				series: [
					{ valueField: 'Count' }
				]
			});
		});
	</script>
</head>
<body>
	<form id="frmMain" runat="server">
	<div id="chartContainer" style="height: 500px; width: 500px">
	</div>
	</form>
</body>
</html>