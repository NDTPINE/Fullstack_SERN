import express from "express";
import { getHomePage, getAboutPage, getCrud,postCRUD } from "../controllers/homeController.js";

const router = express.Router();
let initWebRoutes = (app) => {
    router.get("/", getHomePage);
    router.get("/about", getAboutPage);
    router.get("/crud", getCrud);

    router.post('/post-crud', postCRUD);

    return app.use("/", router);
}

export default initWebRoutes;