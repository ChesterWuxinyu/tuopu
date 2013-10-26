function showdialog(url,width,height) {
    var owidth = window.screen.width;
    var oheight = window.screen.height;
    var left = (screen.availWidth - width) / 2;
    window.showModalDialog(url, "", 'dialogWidth:' + width + 'px;dialogLeft:' + left + ';dialogTop:100;dialogHeight:' + height + 'px;scroll:yes;help:0;status:no;');
}

function winclose(val)
{
    window.returnValue = val;
    window.close();
}



