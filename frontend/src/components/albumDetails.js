import api from "../api/api-actions";
import * as CONSTANTS from "../components/constants";

export default {
    albumDetails,
    addReview
}

function albumDetails(album)
{
    return ` 
        <h1>Album Details</h1>
        <h2>Album Title: ${album.title}</h2>
        <h3>Artist: ${album.artist.name}</h3>
        <p>Record Label: ${album.recordLabel}</p>
        <p>Release Year:  ${album.releaseYear}</p>
        <p>Genre: ${album.genre}</p>

        <h4>Songs:</h4> ${album.songs.map(song => {
            return `
            <ol>
                <li>${song.title}</li>
            </ol>
            ` 
        }).join('')}

        <h1>Reviews:</h1> ${album.reviews.map(review => {
            return `
                <ul>
                    <li>${review.reviewerName}
                        <ul>
                            <li>${review.content}</li>
                            <li>${review.reviewDate}</li>
                        </ul>
                    </li>
                </ul>          
            `;
        }).join('')}

        <label>Reviewer Name:</label><input id="reviewerName" placeholder="Enter your name." />
        <label>Content:</label><input id="reviewContent" placeholder="Enter your review here." />
        <input type=hidden value="${album.id}" id="album_id" />
        <button id="btnAddReview">Add a review!</button>
    `;
}

//Create review needs:
//>>1. HTML representing the form to create a review. 
//2. A function to hook up the button to the form and to do an api call (post).
//3. A function to join these two items.

//Review has
//ReviewerName, Content, AlbumId, DateTime (automatic)

function addReview() {
    const btnAddReview = document.getElementById("btnAddReview");
    var reviewDate = Date.now()

    btnAddReview.addEventListener("click", function() {
        const newReview = {
            ReviewerName: document.getElementById("reviewerName").value,
            Content: document.getElementById("reviewContent").value,
            AlbumId: document.getElementById("album_id").value,
            //ReviewDate: reviewDate
        }

        api.postRequest(CONSTANTS.ReviewAPIURL, newReview, data => {
            //Review Details page here!
            return `
                Review details page goes here!;
            `      
        });
    });
}