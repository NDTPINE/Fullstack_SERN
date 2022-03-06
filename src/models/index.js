
import pkg from "../config/config.js"
const dbConfig = pkg.dbConfig;
import {Sequelize} from "sequelize";
const sequelize = new Sequelize(dbConfig.database, dbConfig.username, dbConfig.password, {
    host: dbConfig.host,
    dialect: dbConfig.dialect,
    operatorsAliases: false,
    pool: {
        max: dbConfig.pool.max,
        min: dbConfig.pool.min,
        acquire: dbConfig.pool.acquire,
        idle: dbConfig.pool.idle
    }
});
let db = {};

db.Sequelize = Sequelize;
db.sequelize = sequelize;

import user from "../models/user.js";
user(sequelize, Sequelize);
// db = async () => {
//     try {
//         await sequelize.authenticate();
//         console.log('Connection has been established successfully.');
//     } catch (error) {
//         console.error('Unable to connect to the database:', error);
//     }
// };


export default  db;