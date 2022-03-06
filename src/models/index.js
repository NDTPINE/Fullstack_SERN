
import  dbConfig  from "../config/config.js"
import Sequelize from "sequelize";
const sequelize = new Sequelize(dbConfig.DB, dbConfig.USER, dbConfig.PASSWORD, {
    host: dbConfig.HOST,
    dialect: dbConfig.dialect,
});
const db = {};
db.Sequelize = Sequelize;
db.sequelize = sequelize;


export default  db;