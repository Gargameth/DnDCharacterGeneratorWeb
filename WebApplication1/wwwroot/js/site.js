// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function GetArrayOfRandomDiceRolls() {
    let every_roll = [];
    for (let i = 0; i < 4; i++) {
        every_roll.push(Math.floor(Math.random() * (6 - 1 + 1) + 1));
    }
    every_roll.sort();
    every_roll.shift();
    return every_roll;
}

function UpdateAttributeField(field_name) {
    let attributeArray = GetArrayOfRandomDiceRolls();
    let result = attributeArray.reduce((previousValue, currentValue) => previousValue + currentValue, 0);
    let stringyResult = result.toString();
    document.getElementById(`${field_name}`).value = stringyResult;
}