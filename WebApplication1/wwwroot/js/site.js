// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function GetArrayOfRandomDiceRolls() {
    let firstDie = Math.floor(Math.random() * (6 - 1 + 1) + 1);
    let secondDie = Math.floor(Math.random() * (6 - 1 + 1) + 1);
    let thirdDie = Math.floor(Math.random() * (6 - 1 + 1) + 1);
    let fourthDie = Math.floor(Math.random() * (6 - 1 + 1) + 1);
    let every_roll = [firstDie, secondDie, thirdDie, fourthDie];
    every_roll.sort();
    every_roll.shift();
    return every_roll;
}
