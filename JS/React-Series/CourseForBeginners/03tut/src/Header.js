import React from 'react'


const Header = ({title}) => {
    const headerStyle={
        backgroundColor:'royalblue',
        color:'#fff',
        display:false
    };
    return (
        <header style={headerStyle}>
            <h1>{title}</h1>
        </header>
    )
}

export default Header

