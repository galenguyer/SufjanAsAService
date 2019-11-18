import React from 'react';

const Header = props => {
    return (
        <header>
            <h1>{props.title}</h1>
            <h5>An Ephemeral, Sad Song by Sufjan (as a Service) Stevens</h5>
        </header>
    );
}

export default Header;
