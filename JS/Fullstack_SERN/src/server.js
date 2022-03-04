import express from "express";
import bodyParser from "bodyParser";
import viewEngine from "viewEngine";
import initWebRoutes from "initWebRoutes";

const app = express();
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extension: true }));

viewEngine(app);
initWebRoutes(app);

const port = process.env.PORT || 8000;
app.listen(port, () => {
    console.log("Port is " + port);
});