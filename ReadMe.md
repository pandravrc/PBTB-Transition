# 機能
- State0とState1、それぞれのStateの間に再生するTrandition01、Trandition10が存在する時、1つの同期BoolSWITCHでそれらの動作をコントロールします。

# 使用法
- 適当な作業フォルダを作成、PBTBを導入して本Editorを入れて下さい。
- Resフォルダに空のアニメーションMODE0,MODE1,MODE2,MODE3,State0,State1,Trandition01,Trandition10を作成して下さい。
-- 初回Buildを通すために必要です。空の必要はありません。
-- Stateはループアニメ、Tranditionは単発アニメを想定しています。
- PBTBメニューからDBTを生成して下さい。
- 適当なGameObjectにAnimatorを適応して次のAAPを設定して下さい。
-- MODE0にMODE　値を0、1～3も同様
-- Trandition01の処理中にT0Finを0、終了後1 10も同様
- 再度PBTBメニューからDBTを生成して下さい。
- MAなどで適当にアバターへAnimatorをマージ、SWITCHを変更するメニュー作成し動作確認下さい

# 注意
- PBTBを使うため一般的に次のリスクがあります。
-- Genフォルダ内ファイルの消失可能性があります。
-- MA設定後再生成した場合、アニメータの設定をし忘れるとプレイモード/ビルドに失敗します。

# 依存関係
- PBTB(PanBlendTreeBuilder)に依存します。

# 開発・動作環境
次の環境で開発し、動作を確認しています。
- VRChat SDK 3.3.0
- Av3 Emulator 3.3.1

# ライセンス
- MIT ライセンスに基づきます。