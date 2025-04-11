var Item1;
var Item2;
var Item3;
var Item4;
var Item5 = [2, 3, 5]; //Array
// var Item6 = 20; //Type Inferring...Number
var obj1 = {
    id: 1,
    name: 'sai',
    address: 'lane1' //Allowed
};
obj1 = {
    id: 2,
    name: 'Durga',
    address: 'lane2' //Allowed
};
obj1 = {
    name: 'Durga',
    address: 'lane2', //Allowed
    id: 2
};
// obj1 = {
//     id:2                //Not Allowed
// };
// function AddNumbers(num1:number,num2:number):number 
// {
//     return num1+num2;
// }
console.log(lValue);
var lValue = 10;
function AddNumbers(num1, num2) {
    return "Result is: ".concat(num1 + num2);
}
function AppendNumber(inp) {
    Item5.push(inp);
}
//ShowMessage("Sai","Hi")
//ShowMessage("sai");
function showMessage(name, Addr) {
    if (Addr === void 0) { Addr = 'Hello'; }
    console.log("".concat(Addr, "! ").concat(name));
}
//ShowMembers(3,5,6,7,8,9)
function ShowMembers() {
    var Nums = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        Nums[_i] = arguments[_i];
    }
    return Nums.join(',');
}
function Doperation(nums, callback) {
    var temp = nums.join('-');
    callback(temp);
}
