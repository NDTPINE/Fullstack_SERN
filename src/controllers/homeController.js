import db from "../models/index.js"
import sequelize from "sequelize"


const getHomePage = async (req, res) => {
    try {
        let data = await db.users.findAll().then(users => {
            console.log(JSON.stringify(users))
        });
        console.log(data);
    } catch (error) {
        console.log("ERROR LOAD USERS");
        console.log(error.stack);
    }
    
    
}
const getAboutPage = (req, res) => {
    return res.render('test/about.ejs');
}

export {getHomePage, getAboutPage}


