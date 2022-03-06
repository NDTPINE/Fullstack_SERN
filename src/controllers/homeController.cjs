const db = require("../models");

const getHomePage = async (req, res) => {
    try {
        
        let data = await db.Users.findAll();
        console.log(data.JSON.parse()); 
        return res.render('homepage.ejs');
    } catch (error) {
        console.log("ERROR LOAD USERS");
        console.log(error.stack);  
    }
} 
const getAboutPage = (req, res) => {
    return res.render('test/about.ejs');
}

exports = {getHomePage, getAboutPage}


