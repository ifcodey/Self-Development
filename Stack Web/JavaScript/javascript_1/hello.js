// console.log((100).toString());
// console.log(100.55.toFixed(1))

// console.log(parseInt("100"));
// console.log(parseInt("100aha"));
// console.log(parseFloat("10.4"));

// console.log(+"100");
// console.log(+"100aha");

// console.log(Number.isInteger(100));
// console.log(Number.isInteger("100"));

// console.log(Math.round(99.5));
// console.log(Math.round(99.4));

// console.log(Math.ceil(101.1));
// console.log(Math.floor(101.9));

// console.log(Math.pow(2,2));
// console.log(Math.trunc(99.5));

// let names = " Ahmed ";
// let list = [1,2,3,4,5,6,7,8,9,10];

// console.log(names)
// console.log(names[1]);
// console.log(names[10]);

// console.log(names.charAt(1));
// console.log(names.charAt(10));

// console.log(names.length);
// console.log(names.trim())
// console.log(names.toUpperCase());

// console.log(names.trim().charAt(2).toUpperCase());

// let x = "web Elzero ahaaa";

// console.log(x.indexOf("web"))
// console.log(x.indexOf("aha"))
// console.log(x.indexOf("h", 2))

// console.log(x.lastIndexOf("h", 2))

// console.log(x.slice(2,))
// console.log(x.slice(-5))
// console.log(x.slice(-5,))

// console.log(x.repeat(2))

// console.log(x.split())
// console.log(x.split(""))
// console.log(x.split(" "))
// console.log(x.split(" ", 2))

// let x = "web Elzero ahaaa";

// console.log(x.substring(2));
// console.log(x.substring(2, 6));
// console.log(x.substring(6, 2));
// console.log(x.substring(-10, 6));

// console.log(10 == "10");
// console.log(10 === "10");

// console.log("Ahmed" === "Shalash")

// let arr = [1, 2, 3, 4, 5, ["Ahmed", "Ali"]];

// console.log(`this number is : ${arr[1]}`)
// console.log(`this number is : ${arr[5]}`)

// console.log(`this number is : ${arr[5, 1]}`)
// console.log(`this number is : ${arr[5][1]}`)

// console.log(arr[1] = 10);
// console.log(arr)

// console.log(Array.isArray(arr));

// console.log(arr.length);

// arr[8] = "wow";
// console.log(arr);

// arr[arr - 1] = 1;
// console.log(arr);

// arr.unshift(0, 0);
// arr.push(1, 1);

// arr.shift(5);
// console.log(arr);

// let arr = [1, 10, -23, "Ahmed", "Ali", 5, -5, "Ahmed"];

// console.log(arr.indexOf("Ahmed"));
// console.log(arr.lastIndexOf("Ahmed"))

// if (arr.indexOf("wow") === -1) {
//     console.log("not exist");
// }

// console.log(arr);
// console.log(arr.sort());
// console.log(arr.reverse());
// console.log(arr.sort().reverse());

// let arr10 = ["Ahmed", "Sayed", "Ali", "Osama", "Gamal", "Ameer"];
// let arr20 = ["Modi", "Bodi", "hasan", "tamer"];
// console.log(arr2);
// console.log(arr2.slice())
// console.log(arr2.slice(0,2))
// console.log(arr2.slice(-3))

// arr2.splice(0, 0)
// console.log(arr2)

// arr2.splice(0, 3, "Ayham", "Abo Nazam")
// console.log(arr2)

// let x = arr10.concat(arr20, "mazen", [1, 2]);
// console.log(x);

// console.log(arr10.join(" - "))
// console.log(arr10.join(" '' "))

// let model = [2022, 2023];

// for (let i = 0; i < arr10.length; i++){
//     console.log("#".repeat(2));
//     console.log(`# ${arr10[i]}`)
//     console.log(model[i] ? model[i] : "Not exist");
// }

// function sayhello(name, age, salary) {
//    var x = console.log(`Your name :${name} and your age :${age} and your salary: ${salary}`);
//     return x;
// }

// console.log(sayhello("Ahmed", 24, 800));

// function taskSalary(start, end, exclude, step) {
//     for (let i = start; i <= end; i += step) {
//         if (exclude[0] < i && exclude[1] < i) {
//             if (i === exclude[0]) {
//                 continue;
//             }
//             console.log(i)
//         }
//     }
// }

// var x = taskSalary(0, 1500, [0, 399], 25);
// console.log(x);

// function cardInfro(userName = "Unknown", age, carNumber = "Unknown", salary) {

//     if (age === undefined) {
//         age = "Unknown";
//     }
//     salary = salary || "Unknwon";

//     return ` Hello Name :${userName} \n Age:${age} \n CardNumber:${carNumber} \n salary:${salary}`;
// }

// console.log(cardInfro());
// var x = cardInfro("Ahmed", 24, 2656545312, 800);
// console.log(x);


// function arrListAdding(...number) {

//     let result = 0;
//     for (let i = 0; i < number.length; i++) {
//         console.log(number[i]);
//         result += number[i];
//     }
//     return `the final result is :${result}`;
// }

// console.log(arrListAdding(10, 20, 30, 40, 50, 60));


// function showIndo(user = "Unkown", age = "Unkown", major = "Unkown", rate = 0, ...skill) {
//     document.write(`<div>`);

//     document.write(`<h2> wecome L ${user}</h2>`);
//     document.write(`<p>Age:${age}`);
//     document.write(`<p>hour rate:${rate}}`);
//     document.write(`<p>major:${major}`);
//     skill.unshift("GoLang")
//     document.write(`<h4>skill:</h4>${skill}`);

//     if(skill.length > 1){
//         document.write(`<h4>skill more than 1:</h4>${skill.join(" | ")}`);
//     }

//     document.write(`</div>`)
// }

// showIndo("Ahmed", 24, "Mechanical Engineer", 4, " C++ ", " JS ", " JAVA ", " PYTHON ");

// function majorityElement(nums) {
//     const map = {};
//     const majorityCount = Math.floor(nums.length / 2);

//     for (let i = 0; i < nums.length; i++) {
//         if (!map[nums[i]]) {
//             map[nums[i]] = 1;
//         } else {
//             map[nums[i]]++;
//         }

//         if (map[nums[i]] > majorityCount) {
//             return nums[i];
//         }
//     }
// }

// var x = majorityElement([3, 2, 3]);
// console.log(x);

// let AnonymousFun = function (num1, num2) {
//     return num1 * num2;
// }

// let ArrowFun = (num1, num2) => {
//     return num1 * num2;
// }

// console.log(AnonymousFun(2, 2));
// console.log(ArrowFun(3, 3));

// document.getElementById("show2").onclick = function () {
//     console.log("AnonymousFun");
// }

// document.getElementById("show").onclick = () => {
//     console.log("ArrowFun");
// }

// function nestedFunction(expectAvg, ...sum) {
//     let result = 0;
//     for (let i = 0; i < sum.length; i++) {
//         result += sum[i];
//     }
//     result = result / sum.length;
//     // console.log(result);

//     function firstFun() {
//         if (expectAvg === result) {
//             return true;
//         } else {
//             return result;
//         }
//     }
//     return firstFun();
// }


// var x = nestedFunction(50, 0, 100)
// console.log(x)

// let print = (num1, num2) => num1 + num2;
// console.log(print(100,500));

// var a = 1;
// let b = 2;


// function showText() {
//     a = 10;
//     var x = 1;
//     let y = 1;
//     console.log(`Function - from global ${a}`);
//     console.log(`Function - from global ${b}`);
// }

// console.log(`from global ${a}`);
// console.log(`from global ${b}`);

// console.log(showText())

// console.log(`from global ${a}`);
// console.log(`from global ${b}`);

// console.log(`from local ${x}`);
// console.log(`from local ${y}`);

// var x = 10;
// let y = 10;

// console.log(x);
// console.log(y);

// if (x === 10) {
//     var x = 50;
//     let y = 50;
// }
// console.log(x);
// console.log(y);


// let x3 = 1000;


// var z1 = 20;
// var z2 = 200;

// function parent() {
//     let x2 = 100;
//     let x1 = 1000;

//     var z3 = 2000;

//     function child() {
//         let x1 = 10;
//         console.log("-------------before-------------");
//         console.log(x1);
//         let x2 = 0;
//         console.log(x2);
//         x3 = 0;
//         console.log(x3);

//         console.log(z1);
//         var z2 = 0;
//         console.log(z2);
//         z3 = 0;
//         console.log(z3);
//     }
//     child()

//     console.log("-------------After-------------");
//     console.log(x1);
//     console.log(x2);
//     console.log(x3);

//     console.log(z1);
//     console.log(z2);
//     console.log(z3);
// }
// console.log(parent())


// let numbers = [1, 2, 3, 5, 6, 7, 8, 9]

// let addarr = numbers.map(function (element, index, arr) {
//     console.log(`the element : ${element}`);
//     console.log(`the element : ${index}`);
//     console.log(`the element : ${arr}`);

//     return element + element;
// }, 10);

// let addarr2 = numbers.map((x) => x + 100);

// console.log(addarr);
// console.log(addarr2);

// let swappingCases = "wOw yA aHMED";
// let invertNumber = [1, -10, 15, 100, -30];
// let ignoreBooleans = "20wOw 10yA";

// let sw = swappingCases.split("").map((ele) => {
//     return ele === ele.toUpperCase() ? ele.toLowerCase() : ele.toUpperCase();

// }).join("");

// let inv = invertNumber.map((ele) => {
//     return -ele;
// })

// let ign = ignoreBooleans.split("").map((ele) => {
//     return isNaN(parseInt(ele)) ? ele : "";
// }).join("");

// console.log(sw);
// console.log(inv);
// console.log(ign);

// let friends = ["waleed", "quesy", "zaki", "ahmed", "bodi"]
// let numbers = [11, 20, 2, 5, 6, 564, 6, 545];

// let filterFreind = friends.filter((ele) => {
//     return ele.startsWith("a");
// })
// console.log(filterFreind);

// let filterEven = numbers.filter((ele) => {
//     return (ele % 2 === 0) ? true : false ;
// })
// console.log(filterEven);

// let arr = [1, 2, 3, 10, 20, 30];

// let x = arr.filter((ele) => {
//     return (ele > 3 && ele < 40);
// })

// console.log(x);


