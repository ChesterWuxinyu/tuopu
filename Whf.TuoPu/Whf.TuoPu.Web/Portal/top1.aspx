<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <link rel="stylesheet" href="../css/adminCss.css" type="text/css">
    <script src="../Script/MdiWin.js"></script>
    <title>top</title>
</head>
<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0">
    <table border="0" width="100%" cellspacing="0" cellpadding="0" id="HrmTop">
        <tr>
            <td width="880" valign="top" background="../images/HRMtopbg.jpg">
                <img src="../images/HRMtitle.jpg" width="988" height="88">
            </td>
            <td width="384" background="../images/HRMtopbg.jpg" height="88" style="background-repeat: repeat-x;
                background-position: left bottom">
                &nbsp;
            </td>
        </tr>
    </table>
    <table border="0" width="100%" cellspacing="0" cellpadding="0" height="23" background="../images/HRMtopmenubg.jpg">
        <tr>
            <td width="580" nowrap style="filter: dropshadow(color=#FFFFFF, offx=1, offy=1);
                font-size: 12; font-family: 宋体, Arial, Helvetica, sans-serif;">
                当前用户：test&nbsp;
            </td>
            <td style='filter: dropshadow(color=#FFFFFF, offx=1, offy=1)' width="10">
                &nbsp;
            </td>
            <td width="98" align="right" nowrap style="filter: dropshadow(color=#FFFFFF, offx=1, offy=1);
                font-size: 12; font-family: 宋体, Arial, Helvetica, sans-serif;">
                当前时间：
            </td>
            <td style='filter: dropshadow(color=#FFFFFF, offx=1, offy=1)' width="10">
            </td>
            <td width="213" nowrap style="filter: dropshadow(color=#FFFFFF, offx=1, offy=1);
                font-size: 12; font-family: 宋体, Arial, Helvetica, sans-serif;">
                <script language="javascript">
                    today = new Date();
                    var hours = today.getHours();
                    var minutes = today.getMinutes();
                    var seconds = today.getSeconds();
                    var timeValue = "<FONT COLOR=black>" + (hours); timeValue += ((minutes < 10) ? "<BLINK><FONT   COLOR=black>:</FONT></BLINK>0" : "<BLINK><FONT COLOR=black>:</FONT></BLINK>") + minutes + "</FONT></FONT>";
                    function initArray() {
                        this.length = initArray.arguments.length
                        for (var i = 0; i < this.length; i++)
                            this[i + 1] = initArray.arguments[i]
                    }
                    var d = new initArray("<font color=black><font-size：12px>星期日", "<font color=RED><font-size：12px>星期一", "<font color=RED><font-size：12px>星期二", "<font color=RED><font-size：12px>星期三", "<font color=RED><font-size：12px>星期四", "<font color=RED><font-size：12px>星期五", "<font   color=GREEN><font-size：12px>星期六");
                    document.write("<font color=black><font font-size：12px>今天是:", today.getYear(), "<font color=black><font font-size：12px>年", "<font color=RED><font font-size：12px>", today.getMonth() + 1, "<font color=black><font font-size：12px>月", "<font color=RED><font font-size：12px>", today.getDate(), "<font color=black><font font-size：12px>日 </FONT>", d[today.getDay() + 1]);
                </script>
            </td>
            <td align="right" valign="top" nowrap style='filter: dropshadow(color=#FFFFFF, offx=1, offy=1)'>
                <a href="Default.aspx?quit=1" target="_parent">
                    <img src="../images/Exit.jpg" width="44" height="21" border="0" align="absmiddle" alt="" /></a>
            </td>
        </tr>
    </table>
</body>
</html>
