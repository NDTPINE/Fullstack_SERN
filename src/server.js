import express from "express"
import bodyParser from "body-parser";
import viewEngine from "./config/viewEngine.js"
import initWebRoutes from "./route/web.js";
import {connectDb} from "./config/connectDb.js"

const app = express();
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));

viewEngine(app);
initWebRoutes(app);

connectDb();

const port = process.env.PORT || 8000;
app.listen(port, () => {
    console.log("Port is " + port);
});