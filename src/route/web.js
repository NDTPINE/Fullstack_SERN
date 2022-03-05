import express from "express";

const router = express.Router();
let initWebRoutes = (app) => {
    router.get("/", (req, res) => {
        return res.send("Hello new world! NDT PINE");
    });

    return app.use("/", router);
}

export default initWebRoutes;