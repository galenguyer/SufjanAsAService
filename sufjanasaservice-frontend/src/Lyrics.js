import React from 'react';
import './Lyrics.css'

const Lyrics = props => {
  return (
      <div className="Lyrics">
          {props.lyrics}
      </div>
  );
}

export default Lyrics;
