import {useEffect} from "react";

export default function Modal({
                                  data = {},
                                  visible = false,
                                  onClose,
                                  component,
                              }) {

    const onKeydown = ({key}) => {
        switch (key) {
            case 'Escape':
                onClose()
                break
            default:
                break
        }
    }

    useEffect(() => {
        document.addEventListener('keydown', onKeydown)
        return () => document.removeEventListener('keydown', onKeydown)
    })


    if (!visible) return null

    return (

        <div style={styles.modal} onClick={onClose}>
            <div style={styles.modal_dialog} onClick={e => e.stopPropagation()}>
                {component}
            </div>
        </div>
    )
}

const styles = {
    modal: {
        position: "fixed",
        top: "0",
        bottom: "0",
        left: "0",
        right: "0",
        width: "100%",
        zIndex: "9999",
        display: "flex",
        alignItems: "center",
        justifyContent: "center",
        backgroundColor: "rgba(0, 0, 0, 0.25)",
    },
    modal_dialog: {
        width: "100%",
        maxWidth: "550px",
        background: "white",
        position: "relative",
        margin: "0 10px",
        padding: "10px 20px 0px 20px",
        maxHeight: "calc(100vh - 40px)",
        textAlign: "left",
        display: "flex",
        flexDirection: "column",
        overflow: "hidden",
        boxShadow: "0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19)",
        borderRadius: 16,
    },
}