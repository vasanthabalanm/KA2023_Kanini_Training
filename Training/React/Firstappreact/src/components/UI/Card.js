import React from 'react';
import '../UI/Card.css'

const Card = (props) => {
    return (
        <div className='content'>
            <div class='card'>
                {props.children}
            </div>
        </div>

    );
}

export default Card;