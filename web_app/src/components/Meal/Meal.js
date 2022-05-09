// import {useParams, useNavigate} from "react-router-dom";
// // import { Dialog } from "@reach/dialog";
// import React from "react";
// import {dataMenu} from "../../api/getData";
//
// export default function Meal() {
//     let {mealId} = useParams();
//     let buttonRef = React.useRef;
//     // let meal = dataMenu.mealId
//
//     console.log(mealId)
//
//     return (
//         <Dialog
//             aria-labelledby="label"
//             // onDismiss={onDismiss}
//             initialFocusRef={buttonRef}
//         >
//             <div
//                 style={{
//                     display: "grid",
//                     justifyContent: "center",
//                     padding: "8px 8px",
//                 }}
//             >
//                 <h1 id="label" style={{ margin: 0 }}>
//                     {/*{image.title}*/}
//                 </h1>
//                 <img
//                     style={{
//                         margin: "16px 0",
//                         borderRadius: "8px",
//                         width: "100%",
//                         height: "auto",
//                     }}
//                     width={400}
//                     height={400}
//                     // src={image.src}
//                     alt=""
//                 />
//                 <button
//                     style={{ display: "block" }}
//                     ref={buttonRef}
//                     // onClick={onDismiss}
//                 >
//                     Close
//                 </button>
//             </div>
//         </Dialog>
//     );
// }