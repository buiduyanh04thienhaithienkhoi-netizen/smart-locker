from flask import Flask, jsonify
import requests

app = Flask(__name__)

ESP32_IP = "192.168.1.10"

@app.route("/open-lock")
def open_lock():

    try:

        url = f"http://{ESP32_IP}/unlock"

        r = requests.get(url)

        return jsonify({
            "success": True,
            "esp32": r.text
        })

    except Exception as e:

        return jsonify({
            "success": False,
            "error": str(e)
        })

if __name__ == "__main__":
    app.run(
        host="0.0.0.0",
        port=5000,
        debug=True
    )