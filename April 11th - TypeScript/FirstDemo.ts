var Item1:string;
var Item2:number;
var Item3:boolean;
var Item4:object;
var Item5:number[] = [2,3,5]; //Array



// var Item6 = 20; //Type Inferring...Number



var obj1 = {
    id:1,
    name:'sai',
    address:'lane1'   //Allowed
};

obj1 = {
    id:2,
    name:'Durga',
    address:'lane2'    //Allowed
};

obj1 = {
    name:'Durga',
    address:'lane2',   //Allowed
    id:2
};

// obj1 = {
//     id:2                //Not Allowed
// };



// function AddNumbers(num1:number,num2:number):number 
// {
//     return num1+num2;
// }


console.log(lValue);
var lValue:any = 10;



function AddNumbers(num1:number,num2:number):string      //Template String
{
    return `Result is: ${num1+num2}`; 
}


function AppendNumber(inp:number):void    //AppendNumber(15);
{   
    Item5.push(inp);
}



//ShowMessage("Sai","Hi")
//ShowMessage("sai");
function showMessage(name:string,Addr:string='Hello'):void   //Default Params
{
    console.log(`${Addr}! ${name}`);
}



//ShowMembers(3,5,6,7,8,9)
function ShowMembers(...Nums:number[]):string
{
    return Nums.join(',');
}


function Doperation(nums:number[],callback:(inp:string)=>void)
{
    var temp = nums.join('-');
    callback(temp);
}