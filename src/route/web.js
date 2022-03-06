import express from "express";
import pkg from "../controllers/homeController.cjs"
const { getHomePage, getAboutPage } = pkg;

const router = express.Router();
let initWebRoutes = (app) => {
    router.get("/", getHomePage);
    router.get("/about", getAboutPage)

    return app.use("/", router);
}

export default initWebRoutes;