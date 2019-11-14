import React, { Component } from 'react';
import Header from './Header';
import Lyrics from './Lyrics';

class App extends Component {
    constructor() {
        super();
        this.state = {
            lyrics: [ "" ],
            title: "",
        }
    }

    componentDidMount() {
        fetch("https://mastrchef.rocks/api/sufjan")
        .then(result => {
            return result.text();    
        })
        .then(result => {
            var lines = []
            result.split('\n').forEach(function(item){
                lines.push(<p>{item}</p>)
            });

            this.setState({lyrics: lines, title: lines[Math.floor(Math.random()*lines.length)]})
        });
    }

    render() {
        return (
            <jsxFragment>
                <Header title={this.state.title} />
                <hr style={{width: "60vw"}} />
                <Lyrics lyrics={this.state.lyrics} />
            </jsxFragment>
        )
    }
}

export default App