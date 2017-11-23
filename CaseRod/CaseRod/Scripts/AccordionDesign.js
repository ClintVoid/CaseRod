function prdctclick(x)
{
    var buttons = document.getElementsByClassName("button");
    var i=0, y;
 
    for (i=0; i <= 40; i++)
    {
        
        if (buttons[i].id != x)
            buttons[i].style.backgroundColor = "white";
        else
            y = i;
    }
    
    if (buttons[y].style.backgroundColor == "white")
        buttons[y].style.backgroundColor = "#aaa";
    else
        buttons[y].style.backgroundColor = "white";
}
function addItem()
{

}
