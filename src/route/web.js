import express from "express";
import { getHomePage, getAboutPage, getCrud, postCRUD, displayCRUD, editCRUD, deleteCRUD }
    from "../controllers/homeController.js";

const router = express.Router();
let initWebRoutes = (app) => {
    router.get("/", getHomePage);
    router.get("/about", getAboutPage);
    router.get("/crud", getCrud);

    router.post('/post-crud', postCRUD);
    router.get('/display', displayCRUD);
    router.get('/edit-crud', editCRUD);
    router.get('/delete-crud', deleteCRUD);
    return app.use("/", router);
}

export default initWebRoutes;