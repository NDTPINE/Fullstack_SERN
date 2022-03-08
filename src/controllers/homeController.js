import db from '../models/index';

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

export {getHomePage, getAboutPage}


