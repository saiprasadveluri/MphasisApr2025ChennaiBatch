interface userInfo
{
    id:string,
    role:string,
    location:string,
    email:string,
    password:string
}
var ulist:userInfo[]=[];
function GetUserData()
{
    fetch('http://localhost:3004/userInfo')//JSON server URL.
    .then(
        (res)=>{
            res.json().then((data)=>{
                ulist=data;
                console.log(ulist);
                ShowData(ulist);
            })
        }
    ).catch(()=>{
        console.log("Error In accessing the data.")
    })
}

function ShowData(EmployeeArr) {
           
    var tblNode = document.getElementById('tblDynamic');
   if(tblNode==null)
    return;
    tblNode.innerHTML = '';
    EmployeeArr.map(obj => {
        var trNew = document.createElement("TR");
        trNew.id = obj.id;
        //Column for each Property
        var tdId = document.createElement("TD");
        var IdText = document.createTextNode(obj.id);
        tdId.appendChild(IdText);
        var tdName = document.createElement("TD");
        var nameText = document.createTextNode(obj.email);
        tdName.appendChild(nameText);
        
        var tdAction = document.createElement("TD");
        tdAction.innerHTML = "<button onclick=DeleteRow('" + trNew.id + "')> Delete</button>";
        
        //Add the columns to new row
        trNew.appendChild(tdId);
        trNew.appendChild(tdName);
        
        trNew.appendChild(tdAction);

        //Add the Row to Table
        tblNode.appendChild(trNew)
    });

    
}