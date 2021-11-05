let countEl = document.getElementById("count-el")
let saveEl = document.getElementById("save-el")
let count = 0
let savebtn = 'Prevoius: '
function increment(){
    count++
    countEl.innerText = count //`${count}`
}

function save(){
    savebtn = `${count} - `
    saveEl.textContent += count + ' - '
    countEl.textContent = 0
    count = 0
}