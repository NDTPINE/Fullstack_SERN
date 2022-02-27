import React from 'react'
import {FaTrashAlt} from 'react-icons/fa';


const LineItems = (item, handleCheck, handleDelete) => {
    return (
        <li className="item" key={item.id}>
                <input 
                type="checkbox"
                onChange={()=>handleCheck(item.id)}
                checked={item.checked}
                />{item.item}
                <label
                style={(item.checked) ?{textDecoration:'line-through'}:null}
                onDoubleClick={() => handleCheck(item.id)}
                role="button"
                tabIndex="0"></label>
             <FaTrashAlt 
                 onClick={() => handleDelete(item.id)}
                 role="button"
                 tabIndex="0"
             ></FaTrashAlt>
            </li>
    )
}

export default LineItems
