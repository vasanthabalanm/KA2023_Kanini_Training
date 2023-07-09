import React from 'react'
import Button from './Botton'
const Modulehandling = () => {
    const handleclick = () => {
        console.log('button clicked');
    }
    const alertclick = () => {
        alert('button clicked');
    }
    return (
        <div>Modulehandling

            <div>
                <Button onclick={handleclick} text="click"></Button>
            </div>
            <div>
                <Button onclick={alertclick} text="alert"></Button>
            </div>
        </div>
    )
}

export default Modulehandling