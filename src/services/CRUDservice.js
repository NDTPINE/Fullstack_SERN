import bcrypt from 'bcryptjs';
import db from '../models/index';

const salt = bcrypt.genSaltSync(10);

const CreateNewUser = async (data) => {
    return new Promise(async (resolve, reject) => {
        try {
            let hashPasswordFromBcryptjs = await hashUserPassword(data.password);
            await db.User.create({
                email: data.email,
                password:hashPasswordFromBcryptjs,
                firstName: data.firstName,
                lastName: data.lastName,
                address: data.address,
                phoneNumber: data.phoneNumber,
                gender: data.gender === '1' ? false : true,
                images: "",
                roleId: data.roleId,
                positionId: ""
            })
            resolve('Create a new user succeed...!');
        } catch (error) {
            reject(error);
        }
    })
    
}

const hashUserPassword = (password) => {
    return new Promise(async (resolve, reject) => {
        try {
            let hashPassword = await bcrypt.hashSync(password, salt);
            resolve(hashPassword);
        } catch (error) {
            reject(error);
        }
    })
}

const getAllUsers = () => {
    return new Promise(async (resolve, reject) => {
        try {
            let users = db.User.findAll({raw:true});
            resolve(users);
        } catch (error) {
            reject(error);
        }
    })
}
const getUserInfoById = (userId) => {
    return new Promise(async (resolve, reject) => {
        try {
            let users =await db.User.findOne({
                where: { id: userId },
                raw: true
            })
            if (users) {
                resolve(users);
            }
            else {
                resolve([]);
            }
        } catch (error) {
            reject(error);
        }
    })
}
const updateUserData = (data) => {
    return new Promise(async (resolve, reject) => {
        try {
            let user = await db.User.findOne({
                
                where: { id: data.id }
            });
            user.set(
                {
                    firstName :data.firstName,
                    lastName : data.lastName,
                    address : data.address,
                    phoneNumber : data.phoneNumber
                }
            )
            await user.save();
            let allUsers = await db.User.findAll();
            resolve(allUsers);
        } catch (error) {
            reject(error);            
        }
    })
}




export {CreateNewUser, getAllUsers,getUserInfoById,updateUserData}