import db from '../models/index';
import { CreateNewUser, getAllUsers, getUserInfoById }
    from '../services/CRUD service';


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
const displayCRUD =async (req, res) => {
    let data = await getAllUsers();
    return res.render('display-crud.ejs',{dataTable:data});
}
const editCRUD =async  (req, res) => {
    const userId = req.query.id;
    if (userId) {
        const userData = await getUserInfoById(userId);
        console.log(userData);
        return res.send("Found a user!");
    } else {
        return res.send("Error! Id is not exist! ");
    }
}

const deleteCRUD = (req, res) => {
    
}

export {getHomePage, getAboutPage,getCrud,postCRUD,displayCRUD, editCRUD, deleteCRUD}


