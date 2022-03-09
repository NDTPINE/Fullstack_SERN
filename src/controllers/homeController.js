import db from '../models/index';
import { CreateNewUser } from '../services/CRUD service';
const getHomePage = async (req, res) => {
    try {
        let data = await db.User.findAll();
        
        return res.render('homepage.ejs', {data:JSON.stringify(data)});
    } catch (error) {
        console.log("ERROR LOAD USERS");
        console.log(error.stack);  
    }
} 
const getAboutPage = (req, res) => {
    return res.render('test/about.ejs');
}
const getCrud = (req, res) => {
    return res.render('crud.ejs');
}
const postCRUD =async (req, res) => {
    let mes = await CreateNewUser(req.body);
    console.log(mes);
    return res.send("post crud from server");
}
export {getHomePage, getAboutPage,getCrud,postCRUD}


