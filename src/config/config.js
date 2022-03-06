const dbConfig = {
  username: "root", 
  password: null,
  database: "checkdb",
  host: "127.0.0.1",
  dialect: "mysql",
  pool: {
    max: 5,
    min: 0,
    acquire: 30000,
    idle: 10000
  }
};

export default dbConfig;
 
